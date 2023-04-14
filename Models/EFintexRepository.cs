using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
/*    [ApiController]*/
    public class EFintexRepository : IintexRepository
    {
        private IntexDbContext context { get; set; }

        public EFintexRepository(IntexDbContext temp)
        {
            context = temp;
        }

        public IQueryable<burialmain> Burials => context.Set<burialmain>();

        public void UpdateBurial(burialmain burial)
        {

            var b = context.Burials.First(x => x.id == burial.id);

            if (b != null)
            {
                b.id = burial.id;
                b.squarenorthsouth = burial.squarenorthsouth;
                b.headdirection = burial.headdirection;
                b.sex = burial.sex;
                b.northsouth = burial.northsouth;
                b.depth = burial.depth;
                b.eastwest = burial.eastwest;
                b.adultsubadult = burial.adultsubadult;
                b.facebundles = burial.facebundles;
                b.southtohead = burial.southtohead;
                b.preservation = burial.preservation;
                b.fieldbookpage = burial.fieldbookpage;
                b.squareeastwest = burial.squareeastwest;
                b.goods = burial.goods;
                b.text = burial.text;
                b.wrapping = burial.wrapping;
                b.haircolor = burial.haircolor;
                b.westtohead = burial.westtohead;
                b.ageatdeath = burial.ageatdeath;
                b.southtofeet = burial.southtofeet;
                b.excavationrecorder = burial.excavationrecorder;
                b.photos = burial.photos;
                b.hair = burial.hair;
                b.burialmaterials = burial.burialmaterials;
                b.dateofexcavation = burial.dateofexcavation;
                b.fieldbookexcavationyear = burial.fieldbookexcavationyear;
                b.clusternumber = burial.clusternumber;
                b.shaftnumber = burial.shaftnumber;

                context.Entry(b).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void CreateBurial(burialmain burial)
        {

            double maxId = context.Burials.Max(b => b.id);

            double nextId = maxId + 1;

            burial.id = nextId;

            context.Burials.Add(burial);
            context.SaveChanges();
        }

        public void DeleteBurial(double burialId)
        {
            var burial = context.Burials.Find(burialId);
            if (burial != null)
            {
                context.Burials.Remove(burial);
                context.SaveChanges();
            }
        }
    }
}
