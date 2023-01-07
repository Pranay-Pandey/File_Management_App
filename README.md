# File_Management_App
File tagging application is a software that allows you to tag your files with certain name,date or place. It enables you to search files via their tags, create new tags,add tags to the files, delete tags and much more.

### This application allows you to:


<ul>
  <li>Add specific tags to the files and folders present on your computer</li>
  <li>Search for those files by the tag name</li>
  <li>Organize your files and folders based on the tags you have given them</li>
</ul>
<p>The tags you can use can be anything, such as:</p>
<ul>
  <li>Workspace related</li>
  <li>Study related</li>
  <li>Deadlines</li>
  <li>Places</li>
  <li>Favorites/bookmarks</li>
</ul>

![image](https://user-images.githubusercontent.com/119414337/210773930-0c2f971b-29a5-4758-bfcf-9552fa5b0e6e.png)


<h2>Modular Design</h2>
<p>This application is designed with the following modules/components:</p>
<ul>
  <li>User interface: includes a categorization of tags according to the disk/drive, a list view of files with tags, a context menu, and a chip select or multi-select tag dropdown menu for files</li>
  <li>Create tag component: allows you to create a new tag</li>
  <li>Edit tag component: allows you to edit a tag name for all the files that are associated with it</li>
  <li>Edit tag in files component: allows you to add or remove tags in a particular file</li>
  <li>Delete tag component: allows you to delete an existing tag (removing it from all files and folders where it is added)</li>
  <li>Searching files component: allows you to search for files using tags</li>
</ul>
<h2>Functionality</h2>
<p>This application includes a custom file manager and the following functions:</p>
<ul>
  <li><code>AddTags(tag_name, fileID)</code>: adds the specified tag to the file with the given fileID</li>
  <li><code>RemoveTags(tag_name, fileID)</code>: removes the specified tag from the file with the given fileID</li>
  <li><code>GetAllFilesFromTag(tag_name)</code>: returns a list of all files with the given tag</li>
  <li><code>GetAllTags()</code>: returns a list of all tags in the application</li>
  <li><code>GetAllTagsByFileID(fileID)</code>: returns a list of all tags for the file with the given fileID</li>
</ul>
<h2>Approach </h2>
<ol>
  <li>Get the file path when the user selects an option from the "add tag" menu (e.g. "Work")</li>
  <li>Fetch the fileID for the file with the given file path</li>
  <li>Store the fileID and tag in a local SQLite database using SQL queries</li>
</ol>
<p>This approach uses the unique fileID as a key value instead of the file name or path to map tags to files. This removes the dependency on the file name or path, which can change if the file is renamed or moved. The fileID, provided by the win library in Windows, is unique to each file and remains unchanged even if the file is relocated or renamed. By using the fileID as the key, copy, paste, rename, and move operations are less complex.</p>

![image](https://user-images.githubusercontent.com/119414337/210773781-d4211be5-3e6a-4f46-b866-1f20d4d338ba.png)




<h2>Technology Stack</h2>
<p>The technology stack for this application includes:</p>
<ul>
  <li>.NET Framework (v4.79)</li>
  <li>SQLite database</li>
  <li>Windows Form</li>
</ul>
