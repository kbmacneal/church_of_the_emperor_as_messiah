# How to add an announcement

It's really simple to do

First, and this is important, **make sure your codebase is up-to-date with master**, otherwise you will be behind and put your code in the wrong spot.

Second, create a new local branch, call it whatever you want

`git checkout -b pull-request-demo`

`git push origin pull-request-demo`

Third, copy and paste this code directly underneath the div that contains the header in Index.cshtml (under Pages)

```
<div class="card border-secondary" style="margin-bottom:15px;">
<div class="card-body">
<h4 class="card-title">TITLE GOES HERE</h4>
<a class="btn btn-outline-secondary" asp-area="" asp-controller="PDF" asp-action="ACTION_NAME">Read &raquo;</a>
</div>
</div>
```

Then add your document to the wwwroot/Documents folder

Then you have to update the controller to pull the right file. go to the controllers folder, and open up PDFController.cs

add a line at the bottom like this

```
public IActionResult ACTION_NAME(PDFModel model)
{
model.link = "https://highchurch.space/Documents/LINK_TO_THE_PDF";
model.set_html();
return View("Index", model);
}
```

The model will automatically generate the HTML needed to generate the embedded object

To create a pull request, you must have changes committed to the your new branch.

`git add --all; git commit -a -m "commit message"; git push`

Go to the repository page on <https://gihub.com/kbmacneal/church_of_the_emperor_as_messiah> . And click on "Pull Request" button in the repo header.

Pick the branch you wish to have merged using the "Head branch" dropdown. You should leave the rest of the fields as is.

Enter a title and description for your pull request. 

Finally, click on the green "Send pull request" button to finish creating the pull request.

You should now see an open pull request.