using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlamourTime.Infrastructure;
using GlamourTime.Domain.Entities;

namespace GlamourTime.Application.Services
{
    
    using GlamourTime.Domain;
    public class AppointmentService
    {
        private readonly GlamourTimeDbContext _context;

        public AppointmentService(GlamourTimeDbContext context)
        {
            _context = context;
        }

        public async Task ScheduleAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }
    }
}