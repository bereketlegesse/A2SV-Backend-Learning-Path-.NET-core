public class Program{
    public static void Main(string [] args){
        
    }
    public static Dictionary<string, int> wordFrequencyCount(string _string){
        Dictionary<string, int> counter = new Dictionary<string, int>();
        string word = "";
        for (int i = 0; i < _string.Length; i++){
            char c = _string[i];
            if(char.IsLetter(c)){
                word += char.ToLower(c);
            }

            else if (word.Length > 0){
                if(counter.ContainsKey(word)){
                    counter[word]++;
                }
                else{
                    counter.Add(word, 1);
                }
                word = "";
            }
        }
        return counter;
        
    }
}