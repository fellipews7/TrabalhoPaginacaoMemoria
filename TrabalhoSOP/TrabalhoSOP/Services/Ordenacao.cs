using TrabalhoSOP.Domain;

namespace TrabalhoSOP.Services
{
    public class Ordenacao
    {
        public List<Frames> Frames { get; set; }

        public Ordenacao(List<Frames> frames)
        {
            Frames = frames;
        }

        public Frames OrdernarListaFifo() => Frames.OrderByDescending(x => x.TempoCarga).FirstOrDefault();

        public Frames OrdernarListaLfu() => Frames.OrderByDescending(x => x.UltimaReferencia).FirstOrDefault();

        public Frames OrdernarListaLru() => Frames.OrderBy(x => x.QuantReferencia).FirstOrDefault();

        public Frames OrdenarListaNru() => Frames.OrderBy(x => x.Br).ThenBy(c => c.Bm).FirstOrDefault();

    }
}
