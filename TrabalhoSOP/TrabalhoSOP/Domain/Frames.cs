using System;
using System.Runtime;

namespace TrabalhoSOP.Domain
{
    public class Frames
    {
        public int Id { get; set; }
        public int QuantReferencia { get; set; }
        public long UltimaReferencia { get; set; }
        public long TempoCarga { get; set; }
        public bool Br { get; set; }
        public bool Bm { get; set; }

        public Frames(int id, int quantReferencia, long ultimaReferencia, long tempoCarga, bool br, bool bm)
        {
            Id = id;
            QuantReferencia = quantReferencia;
            UltimaReferencia = ultimaReferencia;
            TempoCarga = tempoCarga;
            Br = br;
            Bm = bm;
        }

        internal static object OrderBy(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Id: {Id} \n" +
                   $"Quantidade Referencia: {QuantReferencia} \n" +
                   $"Ultima Referencia: {UltimaReferencia} \n" +
                   $"Tempo Carga: {DateTimeOffset.FromUnixTimeMilliseconds(TempoCarga)} \n" +
                   $"BR: {Br} \n" +
                   $"BM: {Bm} \n";
        }

    }
}
