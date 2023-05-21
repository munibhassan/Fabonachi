using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace First_program
{
    public class ClimbingtheLeaderboard
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            Dictionary<int, int> leaderBoard = new Dictionary<int, int>();
            // List<int,int> newRanked = new List<int,int>();
            int[,] array = new int[ranked.Count + player.Count, 2];

            List<List<int>> twoDList = new List<List<int>>();
            List<int> rankList = new List<int>() { };
            List<int> leaderBoardList = new List<int>() { };
            List<string> CombineList = new List<string>() { };
            List<int> playerRank = new List<int>() { };

            twoDList.Add(rankList);
            twoDList.Add(leaderBoardList);
            twoDList.Add(playerRank);

            int rank = 1;
            int counter = 0;
            //foreach (int item in ranked)
            //{

            //for (int item = 0; item < ranked.Count; item++)
            //{
            //    array[item, 0] = ranked[item];

            //    if (ranked.Contains(ranked[item]))
            //    {
            //        array[item, 1] = rank;
            //    }
            //    else
            //    {
            //        rank++;
            //        array[item, 1] = rank;
            //    }

            //}

            //for (int item = ranked.Count; item < player.Count; item++)
            //{
            //    array[item, 0] = player[counter];
            //    if (ranked.Contains(player[counter]))
            //    {
            //        array[item, 1] = rank;
            //    }
            //    else
            //    {

            //    }

            //    counter++;
            //}
            //if (rankList.Contains(item))
            //{
            //    leaderBoardList.Add(rank);
            //    CombineList.Add((rank).ToString());
            //}
            //else
            //{

            //    leaderBoardList.Add(rank);
            //    CombineList.Add((rank).ToString());
            //    rank++;
            //}

            //rankList.Add(item);

            //CombineList[counter] +=","+item.ToString();
            //counter++;

            // }

            //foreach (int i in player)
            //{
            //    rankList.Add(i);
            //}

            var sortedNumbers = rankList.OrderByDescending(n => n).ToList();
            // rankList.Reverse();

            // List<LeaderboardEntry> leaderboard = new List<LeaderboardEntry>();
            //List<(int, int )> leaderboard = new List<(int, int)>();
            //int rankPlayer = 1;
            //foreach (int item in ranked)
            //{
            //    //leaderboard.Add()
            //    if (leaderboard.Contains(item))
            //    {
            //        //leaderBoardList.Add(rank);
            //        //CombineList.Add((rank).ToString());
            //       // rankPlayer;
            //    }
            //    else
            //    {
            //        rankPlayer = rank;
            //        // leaderBoardList.Add(rank);
            //        //CombineList.Add((rank).ToString());
            //        rank++;
            //    }

            //    leaderboard.Add((item, rankPlayer));
            //}

            List<(int, int, string,int)> leaderboard = new List<(int, int, string,int)>();
            int rankPlayer = 1;


            foreach (int item in ranked)
            {
                if (leaderboard.Exists(x => x.Item1 == item))
                {
                    // If the item already exists in the leaderboard, update its rank
                    int existingRank = leaderboard.Find(x => x.Item1 == item).Item2;
                    leaderboard.Add((item, existingRank, "Original",0));
                }
                else
                {
                    // Add the item to the leaderboard with the current rank
                    leaderboard.Add((item, rank, "Original", 0));
                    rank++;
                }
            }

            foreach (var item in player)
            {

                leaderboard.Add((item, rank, "Player", 0));
                rank++;
            }
            leaderboard.Sort((x, y) => y.Item1.CompareTo(x.Item1));


            rank = 1;

            for (int i = 0; i < leaderboard.Count; i++)
            {
                var item = leaderboard[i];
                var updatedTuple = (item.Item1, item.Item2, item.Item3, rank);
                leaderboard[i] = updatedTuple;
                rank++;
            }
            //foreach (var entry in leaderboard)
            //{
            //    if (leaderboard.Exists(x => x.Item1 == entry.Item1))
            //    {

            //    }
            //    else
            //    {
            //        entry.Item4 = rank;
            //    }
            //}

            //for (int i = 0; i < leaderboard.Count; i++)
            //{
            //    if (leaderboard.Exists(x => x.Item1 > leaderboard[i].Item1))
            //    {
            //        var updatedTuple = (leaderboard[i].Item1, leaderboard[i].Item2, leaderboard[i].Item3, rank);
            //       // var updatedTuple = (leaderboard[0].Item1, 150, leaderboard[0].Item3, leaderboard[0].Item4);
            //        leaderboard[i] = updatedTuple;
            //    }
            //    else
            //    {
            //        var updatedTuple = (leaderboard[i].Item1, leaderboard[i].Item2, leaderboard[i].Item3, rank);
            //        leaderboard[i] = updatedTuple;
            //        rank++;

            //    }

            //}

            //foreach (var item in leaderboard)
            //{
            //    if (item.Item1 < currentItem.Item1)
            //    {
            //        // item1 is smaller than the current item
            //        // Perform the desired operations here
            //        var updatedTuple = (leaderboard[i].Item1, leaderboard[i].Item2, leaderboard[i].Item3, rank);
            //        // var updatedTuple = (leaderboard[0].Item1, 150, leaderboard[0].Item3, leaderboard[0].Item4);
            //        leaderboard[i] = updatedTuple;
            //    }
            //}

            //for (int i = 0; i < leaderboard.Count; i++)
            //{
            //    int currentItem1 = leaderboard[i].Item1;
            //    int currentItemRank = rank;

            //    for (int j = 0; j < leaderboard.Count; j++)
            //    {
            //        if (leaderboard[j].Item1 > currentItem1)
            //        {
            //            currentItemRank++;
            //        }
            //    }

            //    var updatedTuple = (leaderboard[i].Item1, leaderboard[i].Item2, leaderboard[i].Item3, currentItemRank);
            //    leaderboard[i] = updatedTuple;
            //}

            return ranked;
        }

        public static List<int> climbingLeaderboardChat(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            List<int> uniqueRanked = ranked.Distinct().ToList();
            int j = uniqueRanked.Count - 1; // Index of the current ranked score

            foreach (int score in player)
            {
                while (j >= 0)
                {
                    if (score >= uniqueRanked[j])
                        j--;
                    else
                        break;
                }

                result.Add(j + 2); // Add 2 because ranks start from 1, not 0
            }

            return result;
        }
    }
   
    public class LeaderboardEntry
    {
        // public int PlayerId { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }

        public string? LeaderBoard { get; set; }

        public int finalRank { get; set; }

    }
}
