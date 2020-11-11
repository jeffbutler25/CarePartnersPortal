using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ServerInfoService
    {

        public static float DriveSpace(string serverName)
        {
            ManagementPath path = new ManagementPath()
            {
                NamespacePath = @"root\cimv2",
                Server = serverName
            };
            ManagementScope scope = new ManagementScope(path);
            string condition = "DriveLetter = 'C:'";
            string[] selectedProperties = new string[] { "FreeSpace", "Capacity"};
            SelectQuery query = new SelectQuery("Win32_Volume", condition, selectedProperties);

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            using (ManagementObjectCollection results = searcher.Get())
            {
                ManagementObject volume = results.Cast<ManagementObject>().SingleOrDefault();

                if (volume != null)
                {
                    float freeSpace = Convert.ToSingle(volume.GetPropertyValue("FreeSpace"));
                    float capacity = Convert.ToSingle(volume.GetPropertyValue("Capacity"));
                    float pctfree = (float)Math.Round((freeSpace / capacity) * 100,2);
                    
                    return pctfree;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
