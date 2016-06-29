using Couchbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouchbaseClientExample
{
    class Program
    {
        private static readonly Cluster Cluster = new Cluster();
        static void Main(string[] args)
        {
            using (var bucket = Cluster.OpenBucket())
            {
                var document = new Document<dynamic>
                {
                    Id = "Hello",
                    Content = new
                    {
                        name = "Couchbase"
                    }
                };

                var upsert = bucket.Upsert(document);

                if (upsert.Success)
                {
                    var get = bucket.GetDocument<dynamic>(document.Id);
                    document = get.Document;
                    var msg = string.Format("{0} {1}!", document.Id, document.Content.name);
                    Console.WriteLine(msg);
                }
                Console.Read();
            }
        }
    }
}
