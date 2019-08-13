function getAllFolders()
{
    $.ajax(
    {
        type: 'GET',
        url: 'http://localhost:3764/api/folder',
        dataType: "json",
        success: function(data)
        {
            let fld = "";
            data.forEach(function(item)
            {
                fld += card(item.id, item.name);
            });
            $('#content').html(fld);
        }
    });
}

function GetFolderByCategory(id)
{
    $.ajax(
    {
        type: 'GET',
        url: `http://localhost:3764/api/folder/category/${id}`,
        dataType: "json",
        success: function(data, textStatus)
        {
            let fold = "";
            data.forEach(function(item)
            {
                fold += card(item.id, item.name);
            });
            $('#content').html(fold);
            $('#crud').html(createFldButton(id));
            $('#delete').html(deleteCtgButton(id));
            
        }
    });
}

function createFolder(categoryId, name)
{
    $.ajax({
        type: 'POST',
        url: 'http://localhost:3764/api/folder',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: `{"CategoryId": "${categoryId}", "name": "${name}" }`,
        success: function(data){
            getAllNotes();
            getAllCategories();
        }
    });
}

function deleteFolder(id){
    $.ajax({
        type: 'DELETE',
        url: `http://localhost:3764/api/folder/${id}`,
        dataType: "json",
        success: function(data)
        {
            getAllNotes();
            getAllCategories();
        }
    });
}

