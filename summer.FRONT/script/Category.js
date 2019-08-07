function getAllCategories()
{
    $.ajax(
    {
        type: 'GET',
        url: 'http://localhost:3764/api/category',
        dataType: "json",
        success: function(data)
        {
            let cat = "";
            data.forEach(function(item)
            {
                cat += category(item.id, item.name);
            });
            $('#ctg').html(cat);
           
        }
    });
}

function createCategory(title)
{
    $.ajax({
        type: "POST",
        url: "http://localhost:3764/api/category",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: `{"name": "${title}"}`,
        success: function(data){
            getAllNotes();
            getAllCategories();
        }
    });
}

function deleteCategory(id)
{
    $.ajax({
        type: "DELETE",
        url: `http://localhost:3764/api/category/${id}`,
        dataType: "json",
        success: function(data){
            getAllCategories();
            getAllNotes();
        }
    })
}


