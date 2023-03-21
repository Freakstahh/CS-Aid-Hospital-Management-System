using System.ComponentModel;

namespace CS_Aid_Hospital_Management_System
{
    public enum DoctorShifts
    {

        [Description("Monday and Thursday, 7AM to 4:30PM")]
        MTH7430,

        [Description("Monday and Thursday, 8AM to 5:30PM")]
        MTH8530,

        [Description("Monday and Thursday, 9AM to 6:30PM")]
        MTH9630,

        [Description("Tuesday and Wednesday, 6AM to 3:30PM")]
        TW6330,

        [Description("Tuesday and Wednesday, 10AM to 7:30PM")]
        TW10730,

        [Description("Tuesday and Wednesday, 11AM to 8:30PM")]
        TW11830,

        [Description("Friday and Saturday, 8AM to 5:30PM")]
        FS8530,

        [Description("Friday and Saturday, 12PM to 9PM")]
        FS129,

        [Description("Friday and Saturday, 7AM to 4:30PM")]
        FS7430
    };

}

/*
public static string GetDescriptionFromEnum(Enum value)
{
     DescriptionAttribute attribute = value.GetType()
     .GetField(value.ToString())
     .GetCustomAttributes(typeof(DescriptionAttribute), false)
     .SingleOrDefault() as DescriptionAttribute;
     return attribute == null ? value.ToString() : attribute.Description;
}

public static string GetDescriptionFromEnum(Enum value)
{
      FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
      DescriptionAttribute[] attributes =
        (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
      return attributes == null && attributes.Length == 0 ? value.ToString() : attributes[0].Description;
}
*/

