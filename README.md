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

emperor_core is deprecated and will not be updated. You are free to use it as a decent example of a Razor style dotnet core app, though there were some problems with it.

emperor_mvc is the site currently being maintained. It uses netcoreapp2.1 (meaning you have to install dotnet-sdk-2.1.300), bootstrap 4. This enables GDPR support (kind of essential these days) and some other goodies down the road.
