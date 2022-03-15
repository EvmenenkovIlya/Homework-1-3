using System;


namespace HW_1_3.Test
{
    public enum TDAMockType
    { 
    empty,
    sort,
    unsort,
    allZero,
    oneElement,
    square,
    mirrorSquare
    }
    public class TwoDimensionalArraysMOCK
    {
        public static int[,] GetMOCK(TDAMockType type)
        { 
            switch (type)
            {
                case TDAMockType.empty:
                    return new int[,] {
                    { },
                    { },
                    { },
                    };
                case TDAMockType.sort:
                    return new int[,] {
                    {-2, -1, 0 },
                    {1, 2, 3 },
                    {4, 5, 6 },
                    {7, 8, 9 },
                    };
                case TDAMockType.unsort:
                    return new int[,] {
                    {-2, 9, 7 },
                    {1, -9, 7 },
                    {0, 5, 2 },
                    };
                case TDAMockType.allZero:
                    return new int[,] {
                    {0, 0, 0 },
                    {0, 0, 0 },
                    {0, 0, 0 },
                    };
                case TDAMockType.oneElement:
                    return new int[,] {
                    {1},
                    {1},
                    {1},
                    };
                case TDAMockType.square:
                    return new int[,] {
                    {1, 3, 3, 3},
                    {0, 1, 3, 3},
                    {0, 0, 1, 3},
                    {0, 0, 0, 1}
                    };

                case TDAMockType.mirrorSquare:
                    return new int[,] {
                    {1, 0, 0, 0},
                    {3, 1, 0, 0},
                    {3, 3, 1, 0},
                    {3, 3, 3, 1}
                    };

                default:
                    throw new Exception("Didn't choose MockType");
            }

        }
    }
}
