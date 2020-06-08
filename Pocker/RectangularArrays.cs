//----------------------------------------------------------------------------------------
//	Copyright © 2007 - 2020 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class includes methods to convert Java rectangular arrays (jagged arrays
//	with inner arrays of the same Length).
//----------------------------------------------------------------------------------------
internal static class RectangularArrays
{
    public static Card[][] RectangularCardArray(int size1, int size2)
    {
        Card[][] newArray = new Card[size1][];
        for (int array1 = 0; array1 < size1; array1++)
        {
            newArray[array1] = new Card[size2];
        }

        return newArray;
    }
}