
string a = Console.ReadLine();

char[] ch = new char[a.Length]; 
char[] chRev = new char[a.Length];
    
for (int i = 0; i < a.Length; i++) { 
    ch[i] = a[i]; 
    chRev[i] = a[i];
} 

Array.Reverse(ch);

int count = 0;

for (int i = 0; i < a.Length; i++) { 
     if(ch[i] == chRev[i]){
        count++;
     }
}
if(count == a.Length){
    Console.WriteLine("Полиндром");
}else{
    Console.WriteLine("Не полиндром");
}

