function getAllNotes()
{
    $.ajax(
    {
        type: 'GET',
        url: `http://localhost:3764/api/note`,
        dataType: "json",
        success: function(data)
        {
            let note = "";
            data.forEach(function(item)
            {
                note += noteCard(item.id, item.name, item.text, item.dateFrom, item.dateTo, item.importance);
            });
            $('#content').html(note);
            $('#crud').html('');
            $('#delete').html('');
           
        }
    });
}

function getNotesByFolder(id)
{
    $.ajax(
    {
        type: 'GET',
        url: `http://localhost:3764/api/note/folder/${id}`,
        dataType: "json",
        success: function(data)
        {
            let note = "";
            data.forEach(function(item)
            {
                note += noteCard(item.id, item.name, item.text, item.dataFrom, item.dataTo, item.importance);
            });
            $('#content').html(note);
            $('#crud').html(createNoteButton(id));
            $('#delete').html(deleteFldButton(id));
        }
    });
}

function createNote(folderId, name, text, dateFrom, dateTo, importance)
{
    $.ajax({
        type: 'POST',
        url: 'http://localhost:3764/api/note',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: `{"FolderId": "${folderId}", "Name": "${name}", "Text": "${text}", "DateFrom": "${dateFrom}", "DateTo": "${dateTo}", "Importance": "${importance}"}`,
        success: function(data){
            getAllNotes();
            getAllCategories();
        }
    })
}