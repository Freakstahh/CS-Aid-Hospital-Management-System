using System.ComponentModel;

namespace CS_Aid_Hospital_Management_System
{
    public enum Departments
    {

        [Description("Outpatient Department")] //Consultants, Investigators, Procedure Makers, Special Services
        OPD,

        [Description("Inpatient Service")] //Provides Lodging, Diet, and Medical Care
        IP,

        [Description("Medical Department")] //Medicine, Surgery, Gynaecology, Obstetrics, Paediatrics, Eye, ENT, Dental, Orthopaedics, Neurology, Cardiology
        MD,

        [Description("Nursing Department")] //Paborito ni Dan
        ND,

        [Description("Paramedical Department")] //Responsible for Maintenance or Restoration of health and normal functioning of the patient
        PMD,

        [Description("Physical Medicine and Rehabilitation Department")] 
        PMRD,

        [Description("Operation Theatre Complex")]
        OT,

        [Description("Pharmacy Department")] //Selects, Purchases, Compounds, Stores, and Dispense all drugs and medications
        PD,

        [Description("Radiology Department")] //X-Ray
        XRYD,

        [Description("Dietary Department")] //Provides Food Service to the client or patient according to their needs and doctor's prescription
        DD,

        [Description("Non-professional Services, Business Management")] //Admitting Department, Administration, 
        BMD,

        [Description("Medical Record Department")]
        MRD,

        [Description("Personnel Department")] //Recruitment of Personnel, Interviewing Prospective Employees, Promotion and Transfer of Employees
        PRD
    };

}