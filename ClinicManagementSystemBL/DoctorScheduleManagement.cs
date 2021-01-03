﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementSystemDAL;
using ClinicManagementSystemDOL.Models;

namespace ClinicManagementSystemBL
{
    public class DoctorScheduleManagement
    {
        /// <summary>
        /// Instance of DoctorSchedule for accessing its methods defined in the DAL
        /// </summary>
        DoctorSchedule doctorSchedule = new DoctorSchedule();
        
        /// <summary>
        /// Retreaves the entire list of time slots from the database
        /// </summary>
        /// <returns>List of Appointment Time Slots</returns>
        public List<AppointmentTime> GetTimeSlots()
        {
            return doctorSchedule.GetTimeSlots();
        }

        /// <summary>
        /// Stores the availability of the doctor as per the schedule generated by doctor
        /// </summary>
        /// <param name="doctorAvailability"></param>
        /// <returns>Flag as true if Added successfully else false</returns>
        public bool MarkAvailability(List<DoctorAvailability> doctorAvailability)
        {
            return doctorSchedule.MarkAvailability(doctorAvailability);
        }
        public AppointmentTime GetExistingFromSchedule(int doctorId, DateTime date)
        {
            return doctorSchedule.GetExistingFromSchedule(doctorId, date);
        }
        public AppointmentTime GetExistingToSchedule(int doctorId, DateTime date)
        {
            return doctorSchedule.GetExistingToSchedule(doctorId, date);
        }
    }
}