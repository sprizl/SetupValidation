using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            TestValidateDto validateDto = new TestValidateDto();
            validateDto.MachineId = 1;
            validateDto.EquipmentIdArray = new int[] { 1, 2, 3 };
            validateDto.JigIdArray = new int[] { 4, 5 };
            validateDto.MaterialIdArray = new int[] { 6, 7 };
            validateDto.CarrierIdArray = new int[] { 8 };

            var jsonContent = JsonConvert.SerializeObject(validateDto);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:56157/api/FTValidator/TestValidate");
            request.Method = "POST";

            UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);

            //request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            //long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    //length = response.ContentLength;
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        Console.Write(reader.ReadToEnd());
                    }
                    Console.Read();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
