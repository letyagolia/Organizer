//Вид категории
function category(id, name)
{
    return `<p><button type="button" class="btn btn-outline-dark bcateg" id="${id}">${name}</button></p>`;
}

//Вид папки
function card(id, name)
{
    return `<div class="card col-3 mx-4 my-2" id="${id}">
                <img class="card-img-top float-right" src="img/bulavka.png" style="width: 5rem;" alt="Card image">
                <div class="card-body">
                    <button type="button" class="btn btn-outline-dark bfold" id="${id}">${name}</button>

            </div></div>`;
}

//Вид заметки
function noteCard(id, name, text, dateFrom, dateTo, importance)
{
    return `<div class="card col-3 mx-4 my-2" id="${id}">
                
                <div class="card-body">
                    <h4>${name}</h4>
                    <p>${text}</p>
                    <p>${dateFrom} - ${dateTo}</p>
                    <p>${importance}</p>
                    <p><button type="button" class="btn btn-secondary deleteNBtn" id="${id}">Удалить</button><button type="button" class="btn btn-secondary updateCBtn" id="${id}">Изменить</button></p>
                    
            </div></div>`;
}

//Форма для создания категории
function CreateCategoryForm()
{
    return `<div class="col-12">
                <h1>Новая категория</h1>
            </div>
            <div class="col-12">
            <form name="createForm">
                <div class="form-group">
                    <label>Название:</label>
                    <input id="i_title" class="form-control" name="title" />
                </div>
            </form>
            <button type="button" class="btn btn-outline-dark" id="createCategoryBtn">Добавить</button>
            </div>`;
}

//Кнопка "Удалить категорию"
function deleteCtgButton(id){
    return `<button type="button" class="btn btn-secondary deleteCBtn" id="${id}">Удалить категорию</button>`;
}



//Кнопка "Новая папка"
function createFldButton(id){
    return `<button type="button" class="btn btn-secondary newFld" id="${id}">Новая папка</button>`;
}

//Форма для создания папки
function CreateFolderForm(id)
{
     return `<div class="col-12">
                <h1>Новая папка</h1>
            </div>
            <div class="col-12">
            <form name="createFldForm">
                <div class="form-group">
                    <label>Категория:</label>
                    <input id="i_title" class="form-control" name="categoryId" value="${id}" />
                    <label>Название:</label>
                    <input id="i_title" class="form-control" name="name" />
                </div>
            </form>
            <button type="button" class="btn btn-outline-dark" id="createFoldBtn">Добавить</button>
            </div>`;
}

//Кнопка "Удалить папку"
function deleteFldButton(id)
{
    return `<button type="button" class="btn btn-secondary deleteFBtn" id="${id}">Удалить папку</button>`;
}

//Кнопка "Создать запись"
function createNoteButton(id){
    return `<button type="button" class="btn btn-secondary newNote" id="${id}">Создать запись</button>`;
}

//Форма для создания записи
function createNoteForm(id)
{
         return `<div class="col-12">
                <h1>Задача</h1>
            </div>
            <div class="col-12">
            <form name="createNoteForm">
                <div class="form-group">
                    <label>Папка:</label>
                    <input id="i_title" class="form-control" name="folderId" value="${id}" />
                    <label>Название:</label>
                    <input id="i_title" class="form-control" name="name" />
                    <label>Описание:</label>
                    <input id="i_title" class="form-control" name="text" />
                    <label>Дата создания:</label>
                    <input id="i_title" class="form-control" name="dateFrom" />
                    <label>Дата завершения:</label>
                    <input id="i_title" class="form-control" name="dateTo" />
                    <label>Важность:</label>
                    <input id="i_title" class="form-control" name="importance" />
                </div>
            </form>
            <button type="button" class="btn btn-outline-dark" id="createNoteBtn">Добавить</button>
            </div>`;
}
