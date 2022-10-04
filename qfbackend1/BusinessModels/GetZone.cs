using System.Drawing;

namespace qfbackend1.BusinessModels
{
    public class GetZone
    {
       public static int Run(double latitude, double longitude) // latitude is horizontal lines  // longitude is vertical lines
        {
            PointF addressPoint = new PointF((float)longitude, (float)latitude);

            Zones zonesObject = new Zones();
            List<PointF[]> zones = zonesObject.GetZones();

            int zoneNumber = 0;

            for (int i = 1; i <= zones.Count; i++) 
            {
               if(IsPointInPolygon(zones[i - 1], addressPoint))
                {
                    zoneNumber = i;
                    break;
                }
            }

            return zoneNumber;
        }

        public static bool IsPointInPolygon(PointF[] polygon, PointF addressPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < addressPoint.Y && polygon[j].Y >= addressPoint.Y || polygon[j].Y < addressPoint.Y && polygon[i].Y >= addressPoint.Y)
                {
                    if (polygon[i].X + (addressPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < addressPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
    }
}
