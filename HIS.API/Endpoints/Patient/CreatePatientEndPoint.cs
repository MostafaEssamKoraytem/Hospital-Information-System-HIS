
using HIS.Application.DTO.Patient;
using HIS.Application.Interface;
using HIS.Application.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HIS.API.Endpoints.Patient
{
    public class CreatePatientEndPoint 
    {
        public static async Task MapEndPoint(IEndpointRouteBuilder app)
        {
            app.MapPost("api/MinimalAPI/patients/create" , 
                async ([FromBody] CreatePatientRequest request,
                IPatientService patientService,
                 CancellationToken cancellationToken) =>
                {


                await patientService.CreateAsync(request);

                return Results.Created($"Patient ID: {Guid.NewGuid()}", Guid.NewGuid());
            })
             .WithName("Created Patient")
            .Produces<Guid>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);
        }
    }
}
