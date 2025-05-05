int[] nums = { 1, 2, 3, 1 };
Console.WriteLine($"Input: {IntArrayString(nums)}");
Console.WriteLine($"Output: {HasDuplicateValue(nums)}");
int []nums2 = { 1, 2, 3, 4 };
Console.WriteLine($"Input: {IntArrayString(nums2)}");
Console.WriteLine($"Output: {HasDuplicateValue(nums2)}");
int[] nums3 = { 1, 2, 3, 3, 3, 4 };
Console.WriteLine($"Input: {IntArrayString(nums3)}");
Console.WriteLine($"Output: {HasDuplicateValue(nums3)}");

bool HasDuplicateValue(int[] nums)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (freq.ContainsKey(num))
        {
            return true;
        }
        else
        {
            freq[num] = 1;
        }
    }
    return false;
}

string IntArrayString(int[] nums)
{
    return "[" + string.Join(", ", nums) + "]";
}