public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            while(left < right && !isAlphanumeric(s[left]))
            {
                left++;
            }
            while(right > left && !isAlphanumeric(s[right]))
            {
                right--;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    bool isAlphanumeric(char c){
        return (c >= 'a' && c <= 'z') ||
               (c >= 'A' && c <= 'Z') ||
               (c >= '0' && c <= '9');
    }
}
