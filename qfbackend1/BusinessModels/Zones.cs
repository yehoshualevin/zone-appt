using System.Drawing;

namespace qfbackend1.BusinessModels
{
    public class Zones
    {
        PointF z1p1 = new PointF(-74.29644358502593F, 40.1515104129476F);
        PointF z1p2 = new PointF(-74.29791418177042F, 40.1381679627235F);
        PointF z1p3 = new PointF(-74.24286131169607F, 40.11082320264303F);
        PointF z1p4 = new PointF(-74.24955452349903F, 40.14253111108889F);
        PointF z1p5 = new PointF(-74.26128349703883F, 40.1522462730166F);
        

        PointF z2p1 = new PointF(-74.2398341576866F, 40.11251039197944F);
        PointF z2p2 = new PointF(-74.25548823344936F, 40.08637410793541F);
        PointF z2p3 = new PointF(-74.21564320904702F, 40.08417521245932F);
        PointF z2p4 = new PointF(-74.22063347352618F, 40.10862292003677F);
        

        PointF z3p1 = new PointF(-74.21575453186627F, 40.0844198050007F);
        PointF z3p2 = new PointF(-74.19199838972784F, 40.08040637196378F);
        PointF z3p3 = new PointF(-74.18984071786768F, 40.10785949955258F);
        PointF z3p4 = new PointF(-74.22048291326627F, 40.10864475530632F);
       

        PointF z4p1 = new PointF(-74.2553626499315F, 40.08525309319516F);
        PointF z4p2 = new PointF(-74.2636712874246F, 40.05149079684261F);
        PointF z4p3 = new PointF(-74.23305823199964F, 40.03627205734474F);
        PointF z4p4 = new PointF(-74.21410164810909F, 40.0484453935527F);
        PointF z4p5 = new PointF(-74.21606432189034F, 40.08311293570754F);
        

        PointF z5p1 = new PointF(-74.21464002050759F, 40.08293208904119F);
        PointF z5p2 = new PointF(-74.21220198278168F, 40.04499811670745F);
        PointF z5p3 = new PointF(-74.18732864698626F, 40.04971516379172F);
        PointF z5p4 = new PointF(-74.19161548612031F, 40.07912876208776F);

        public List<PointF[]> GetZones()
        {
            PointF[] zone1 = new PointF[] { z1p1, z1p2, z1p3, z1p4, z1p5 };
            PointF[] zone2 = new PointF[] { z2p1, z2p2, z2p3, z2p4 };
            PointF[] zone3 = new PointF[] { z3p1, z3p2, z3p3, z3p4 };
            PointF[] zone4 = new PointF[] { z4p1, z4p2, z4p3, z4p4, z4p5 };
            PointF[] zone5 = new PointF[] { z5p1, z5p2, z5p3, z5p4 };

            List<PointF[]> allZones = new List<PointF[]>();
            allZones.Add(zone1);
            allZones.Add(zone2);    
            allZones.Add(zone3);
            allZones.Add(zone4);
            allZones.Add(zone5);

            return allZones;
        }
    }
}
