Developed using .Net6
Author : Anand Naikar
Email : anandyn29@gmail.com

1. Below things to be configured in 'DevopsConfig.json'
   a. DevOpsUrl -  to your orginsation Devops URL
   b. PersonalAccessToken - Create a personal access token in your DevOps account
   c. Projects - Update list of projects separated by comma
   d. AssignedUsers - Add assigned user for whom task has to be fetched.
				   Set 'SendReport=true' if mail has to sent
   e. RequiredFields - Set of required fields whose data has be reported. Add any additional fields if required according to your needs.
   f. Email - Update sender name, Email Address. 
           Sender password can be encrypted using 'Encryptor.exe'. Set 'SenderPassword=false' if not encrypted 
   
2. MessageBody.txt file - Your email body html is defined here (Note: Donot modify anything enclosed within curly braces {{}} )
3. Encrypted password for sender email can be generated using 'Encryptor.exe'