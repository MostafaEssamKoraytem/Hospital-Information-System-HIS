using HIS.Application.DTO.Patient;
using HIS.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HIS.API.Endpoints.Patient
{
    public sealed class UpdatePatientEndPoint 
    {
        public static async Task MapEndPoint(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/MinimalAPI/patients/{patientId:guid}",
                async (
                    Guid patientId,
                    [FromBody] UpdatePatientRequest request,
                    IPatientService patientService,
                    CancellationToken cancellationToken) =>
                {
                    await patientService.UpdatePatientAsync(
                        patientId,
                        request,
                        cancellationToken);

                    return Results.NoContent();
                })
                .WithName("UpdatePatient")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status400BadRequest)
                .Produces(StatusCodes.Status404NotFound);
        }


    }

      
}
