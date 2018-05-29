# How to add an announcement

It's really simple to do

First, and this is important, **make sure your codebase is up-to-date with master**, otherwise you will be behind and put your code in the wrong spot.

Second, create a new local branch, call it whatever you want

`git checkout -b pull-request-demo`

`git push origin pull-request-demo`

Third, copy and paste this code directly underneath the div that contains the header in Index.cshtml (under Pages)
```
<div class="row">

<div class="jumbotron">

<h4 class="display-4">The Header Goes Here</h4>

<p class="lead">

<a class="btn btn-secondary btn-lg" href="/Documents/name_of_your_document.extension" role="button">Read &raquo;</a>

</p>

</div>

</div>
```

Then add your document to the wwwroot/Documents folder

To create a pull request, you must have changes committed to the your new branch.

`git add --all; git commit -a -m "commit message"; git push`

Go to the repository page on <https://gihub.com/kbmacneal/church_of_the_emperor_as_messiah> . And click on "Pull Request" button in the repo header.

Pick the branch you wish to have merged using the "Head branch" dropdown. You should leave the rest of the fields as is.

Enter a title and description for your pull request. 

Finally, click on the green "Send pull request" button to finish creating the pull request.

You should now see an open pull request.