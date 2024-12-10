All right, to add your stuff


Step 1) Make ur classes inside MODELS!

Step 2) go to the pages inside componets
then add a scaffold item, look for the ur class but make sure it includes model in there

Step 3) The scaffold item creates razor applications, with that ur able to pretty much implement the visual and below u add a code segment.

ex)

@code
public pizza(string party){
  public bool cheese;
}





FOR THE GIT HUBB!!!

1) Pull the latest changes before starting any work.

2) Make your changes and commit them.

3) Pull again before pushing, to avoid conflicts.

4) If there are no conflicts, push your changes.

5) If there are conflicts, resolve them manually, commit the resolved files, and then push.




FOR MY DOG PROFILE (SOME THINGS HAVENT BEEN IMPLEMENTED, JUST THE IDEA)

Create.razor ----> add dogs
Delete.razor -----> remove dogs
Edit.razor ----> edit dogs

I renamed index.razor to view
thought it would be better to repurpose it to view all listings


With that being said, everything is a little weird
check the nav menu

for ex)


<div class="nav-item px-3">
            <NavLink class="nav-link" href="user">
                <span class="bi bi-plus-square-fill-nav-menu" aria-hidden="true"></span> User Profile
            </NavLink>
        </div>

--

the href goes to the url its appointed to, at the end where it says user profile it will change the name of the text,
inside user profile ryan with the index i change the link to user so it would do that, but im sure it will prob be changed i was just testing it.

Renamed .razor files for clarity
DogProfilePages is a folder for all of the pages that have to do with listings

Defaults Seem to be the pages on the left (navbar pages)

Application Pages are for applications

User Pages have to do with creating an account
