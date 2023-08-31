using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using BenchmarkDotNet.Attributes;

namespace fileGetter
{
    [MemoryDiagnoser]
    public class FileReader
    {
        HttpClient httpClient = new HttpClient();
        [Benchmark]
        public async Task GetData()
        {
            try
            {

                var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                var responseBody = await response.Content.ReadAsStringAsync();
                List<Model>? model = JsonConvert.DeserializeObject<List<Model>>(responseBody);

                if (model != null && model.Count > 0)
                {
                    string path = "/Users/admin/Documents/fileGetter/kokoData.csv";
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine("Id, UserId, Title");

                        if (!File.Exists(path))
                        {
                            File.Create(path);
                        }

                        model.ForEach(x =>writer.WriteLine($"{x.Id},{x.UserId},{x.Title}"));

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            finally
            {
                httpClient.Dispose();
            }
        }
    }
}