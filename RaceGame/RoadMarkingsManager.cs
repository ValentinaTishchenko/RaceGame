
namespace Race
{
    public class RoadMarkingsManager
    {
        private readonly Label[][] allLanes;

        public RoadMarkingsManager(params Label[][] lanesArrays)
        {
            allLanes = lanesArrays;
        }

        public int[] GetLanePositions(int formWidth)
        {
           
            var lanePositions = new int[GameConstants.totalLanes];

            int laneWidth = formWidth / GameConstants.totalLanes;
            int halfLaneWidth = laneWidth / 2;

            for (int i = 0; i < GameConstants.totalLanes; i++)
            {
                lanePositions[i] = i * laneWidth + halfLaneWidth;
            }

            return lanePositions;

           
        }

        public void MoveAllMarkings(int carSpeed, int formHeight)
        {
            foreach (var lanes in allLanes)
            {
                MoveSingleLaneMarkings(lanes, carSpeed, formHeight);
            }
        }

        private void MoveSingleLaneMarkings(Label[] lanes, int carSpeed, int formHeight)
        {
            foreach (var lane in lanes)
            {
                lane.Top += carSpeed;
                if (lane.Top >= formHeight)
                {
                    lane.Top = -lane.Height;
                }
            }
        }
    }
}
