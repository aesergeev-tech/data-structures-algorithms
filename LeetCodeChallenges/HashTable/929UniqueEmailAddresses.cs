namespace HashTable;

public partial class Solution {
    public int NumUniqueEmails(string[] emails) {
        var uniqueEmails = new HashSet<string>();
        foreach(var email in emails){
            var emailNames = email.Split('@');
            var localName = emailNames[0];
            var domainName = emailNames[1];
            if(localName.Contains('+')){
                localName = localName.Split('+')[0];  
            }
            localName = localName.Replace(".",String.Empty);
            var forwardedEmail = localName +"@"+ domainName;
            uniqueEmails.Add(forwardedEmail);   
        }
        return uniqueEmails.Count;
    }
}