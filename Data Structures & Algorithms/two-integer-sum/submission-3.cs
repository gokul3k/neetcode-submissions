public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
           if(dict.TryGetValue(target-nums[i], out int matchFound)){
            //match found return the result array of two position of no's
                return new int[]{matchFound,i};
           }else{
                dict[nums[i]]=i;
           }
        }
     return new int[] {};
    }
}
