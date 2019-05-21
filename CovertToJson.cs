using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    public class CovertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            //konversi objek mahasiswa ke json
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("Hasil konversi ke json:\n");
            Console.WriteLine(json);
        }
    }
}
