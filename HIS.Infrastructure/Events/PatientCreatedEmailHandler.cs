using HIS.Domain.Aggregates.PatientAggregate.DomainEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Infrastructure.Events
{
    public class PatientCreatedEmailHandler : INotificationHandler<INotificationWrapper<PatientCreatedDomainEvent>>
    {
        //private readonly IEmailService _emailService;

        //public PatientCreatedEmailHandler(IEmailService emailService)
        //{
        //    _emailService = emailService;
        //}

        public Task Handle(INotificationWrapper<PatientCreatedDomainEvent> notification, CancellationToken cancellationToken)
        {

            //    await _emailService.SendAsync(
            //    "admin@hospital.com",
            //    "New Patient Registered",
            //    $"Patient Id: {notification.PatientId}");

            return Task.CompletedTask;
        }

       
    }
}
