using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace DepthFirstSearch.稀疏相似度
{
    public class Solution
    {
        public IList<string> ComputeSimilarities(int[][] docs)
        {
            List<string> resultList = new List<string>();

            if (docs == null || docs.Length == 0)
            {
                return resultList;
            }

            var strFormat = "{0},{1}: {2}";

            for (int i = 0; i < docs.Length; i++)
            {
                if (docs[i].Length != 0)
                {
                    for (int j = i + 1; j < docs.Length; j++)
                    {
                        if (docs[j].Length != 0)
                        {
                            var interSection = CalcInterSection(docs[i], docs[j]);
                            if (interSection != 0)
                            {
                                var union = CalcUnion(docs[i], docs[j]);
                                resultList.Add(string.Format(strFormat, i, j,
                                    (interSection * 1.0 / union + 1e-9).ToString("f4")));
                            }
                        }
                    }
                }
            }

            return resultList;
        }

        private int CalcUnion(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>();
            foreach (var num in nums1)
            {
                set.Add(num);
            }

            foreach (var num in nums2)
            {
                set.Add(num);
            }

            return set.Count;
        }

        private int CalcInterSection(int[] nums1, int[] nums2)
        {
            var count = 0;
            var list = nums1.ToList();
            foreach (var num in nums2)
            {
                if (list.Contains(num))
                {
                    count++;
                }
            }

            return count;
        }
    }
}