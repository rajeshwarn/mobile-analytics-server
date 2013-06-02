##Installation Instructions##

Our mobile analytics solution is very well documented, easy to use and simple to install, below are the instructions. 
If you have any suggestions or issues let us know on our Google group https://groups.google.com/forum/?fromgroups#!forum/appacts

#####Prerequisite software:#####

    IIS6+
    .NET 4.0+
    MongoDB 2.3+



#####Projects need to publish:#####

    AppActs.API.WebService
    AppActs.Client.WebSite

These two projects are seperate so you can scale your mobile analytics solution if you wish to.
That being said for most apps you will get away with just having one server that handles requests and displays data.



#####Basic setup would be:#####

    www.appacts.yourserver.com/ <- AppActs.Cient.WebSite files go here
    www.appacts.yourserver.com/api/  <-  AppActs.API.WebService files go here, this can be a virtual directory



#####Update:#####

    AppConfig/ConnectionStrings.config <-default will work automatically, but this can be changed if you have extra security


#####Go to:#####
  
      www.appacts.yourserver.com/login.aspx
      Username: admin@admin.com
      Password: admin

Enjoy!


