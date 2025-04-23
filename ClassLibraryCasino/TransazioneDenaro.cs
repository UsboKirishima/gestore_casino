using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class TransazioneDenaro
    {
        private DateTime data;
        private double fiches;
        private double contanti;

        public TransazioneDenaro(double fiches, double contanti)
        {
            this.Data = DateTime.Now;
            this.Fiches = fiches;
            this.Contanti = contanti;
        }

        public DateTime Data { get => data; set => data = value; }
        public double Fiches { get => fiches; set => fiches = value; }
        public double Contanti { get => contanti; set => contanti = value; }

        public BindingList<TransazioneDenaro> GetSampleData()
        {
            return new BindingList<TransazioneDenaro>
            {
                new TransazioneDenaro(100, 50),
                new TransazioneDenaro(200, 100),
                new TransazioneDenaro(300, 150),
                new TransazioneDenaro(400, 200)
            };
        }
    }
}
