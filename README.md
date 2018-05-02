# Webpages for the Church of the Emporer-as-Messiah

We need developers! Even if you only know css/html you can contribute. File a pull request and I will review.

## Development
- Install the the Dotnet 4.7.1 SDK
	- https://www.microsoft.com/en-us/download/details.aspx?id=56119
- (Optional) Install VS 2017 Community
	- choco install visualstudio2017community -y
- Install git
	- choco install git -y
- Clone the Repo
	- git clone https://github.com/kbmacneal/church_of_the_emperor_as_messiah.git
- Add your changes
- File a pull request.
- That's it!

The core website is built to be compatible with an Azure Web App Shared instance. It doesn't have a lot of complicated logic, so it should be fairly snappy.

The bot is designed to be deployed as a continuous web job on azure, for about 50 bucks a month at the time of this writing.

If that is too steep, you can run the bot_core on an AWS EC2 instance for about half that, though setup is a little more involved.
