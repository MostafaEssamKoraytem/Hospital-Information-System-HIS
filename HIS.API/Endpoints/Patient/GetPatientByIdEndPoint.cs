using HIS.Application.DTO.Patient;
using HIS.Application.Interface;

namespace HIS.API.Endpoints.Patient
{
    public sealed class GetPatientByIdEndPoint
    {
        public static async Task MapEndPoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/MinimalAPI/patients/{patientId:guid}",
                async (
                    Guid patientId,
                    IPatientService patientService,
                    CancellationToken cancellationToken) =>
                {
                    var patient =
                        await patientService.GetByIdAsync(patientId);

                    return patient is null
                        ? Results.NotFound()
                        : Results.Ok(patient);
                })
                .WithName("GetPatientById")
                .Produces<PatientDetailsDto>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound);
        }

        
    }
}
