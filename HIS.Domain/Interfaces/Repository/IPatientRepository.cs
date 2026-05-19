using HIS.Domain.Aggregates.PatientAggregate.Entities;
using HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Interfaces.Repository
{
    public interface IPatientRepository
    {
        Task<bool> ExistsDuplicateActivePatientAsync(string nationalIdentity, string phoneNumber);

        Task<bool> HasActiveAppointmentsAsync(Guid patientId);

        //---------------------

        Task AddAsync(Patient patient);

        Task<Patient?> GetByIdAsync(Guid patientId);

        Task UpdateAsync(Patient patient);

        //4 upload medical record function
        // check vires csan 
        // upload to external storage and get url
        // save file name and meta data to db
        Task UploadMedicalDocumentAsync(Guid patientId,DocumentRecord document,CancellationToken cancellationToken = default);

        // get url from db to download document and get document directly from storage
        Task<IReadOnlyCollection<DocumentRecord>> GetPatientDocumentsAsync(
            Guid patientId,CancellationToken cancellationToken = default);
     
        Task AddMedicalHistoryEntryAsync(Guid patientId,MedicalRecord medicalRecord,
          CancellationToken cancellationToken = default);

        Task<IReadOnlyCollection<Patient>> SearchPatientsAsync(string? name, string? nationalIdentity,
       string? mrn, string? phoneNumber, int pageNumber, int pageSize);



        Task DeactivatePatientAsync(Guid patientId,
        CancellationToken cancellationToken = default);


    }
}
