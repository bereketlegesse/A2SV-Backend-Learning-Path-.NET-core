public class Program{
    public static void Main(string [] args){

    }
    
    public static bool palindromCheck(string _string){
        int left = 0;
        int right = _string.Length - 1;

        while(left < right){
            if (char.IsLetter(_string[left]) && char.IsLetter(_string[right])){
                if(char.ToLower(_string[left]) == char.ToLower(_string[right])){
                    left ++ ;
                    right -- ;
                }
                else{
                    return false;
                }
            }

            else if(char.IsLetter(_string[left])){
                right -- ;
            }

            else{
                left ++ ;
            }
        }
        return true;        
    }
}