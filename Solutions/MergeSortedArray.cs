namespace Solutions;

public static class MergeSortedArray {    
    public static void Run(int[] nums1, int m, int[] nums2, int n) {
        var index1 =  m - 1;
        var index2 = n - 1;
        for (var i = m + n - 1; i >= 0; i--) {
            var num2Greater = 
                index2 >= 0 && (index1 < 0 || nums2[index2] > nums1[index1]);

            if (num2Greater) {
                nums1[i] = nums2[index2];
                index2 -= 1;
            } else {
                nums1[i] = nums1[index1];
                index1 -= 1;
            }
        }
    }
}