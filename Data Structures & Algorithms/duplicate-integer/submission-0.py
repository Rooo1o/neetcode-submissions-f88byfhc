class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        for number in nums: 
            if nums.count(number) > 1:
                return True
        return False