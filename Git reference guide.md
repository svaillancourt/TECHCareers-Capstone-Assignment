## Intial Project Start 

> git init
> git commit -m "comment"
> git push origin master

### Creating a new branch & pushing data

> git checkout -b branchname
> git checkout -b stephaneBranch
> git branch ( this verifies existing branches)
> git push origin stephaneBranch 

### Adding the remote repo url 

> git remote -v
> git remote add origin https://github.com/user/repo.git

### Updating local branch
> git pull https://github.com/user/repo.git
> git stash (Some cases you might need to save before pulling)

### Verify new remote

> origin  https://github.com/user/repo.git (fetch)
> origin  https://github.com/user/repo.git (push)