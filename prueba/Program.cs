string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");
for(int i = 0; i<words.Length; i++){
    words[i] = string.Join("", words[i].ToCharArray().Reverse());
}//End for
Console.WriteLine(pangram);
Console.WriteLine(string.Join(" ",words));