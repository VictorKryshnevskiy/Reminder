# Reminder
Я создал данное приложение для собственного пользования. Потребность в нем возникла, когда я захотел систематизировать и упорядочить не только ежедневные задачи, но и вещи, которые происходят достаточно редко, как ТО автомобиля.  
В приложении есть базовые возможности для создания, редактирования и удаления событий.  
![Create](/Создание.JPG)  
При запуске - список событий перед глазами с возможностью сортировки.  
![List](/Список.JPG)  
Внутри события реализована доска Канбан с возможностью перетаскивания элементов и обновления статуса задачи.  
![Kanban](/Kanban.gif)  
Реализованы 2 типа напоминания о событии: циклическое напоминание с определенной даты, указаной пользователем и частота отправки напоминаний, а также разовое напоминание (например, за день или за пол часа до события)  
Приложение работает в фоновом режиме и не мешает, находится там, где скрытые значки.  
Reminder написан на WinForms, в первой версии приложения для сохранения и изменения данных использовал сериализацию и десериализацию JSON.  
Позже реализовал базу данных используя EntityFramework с подходом CodeFirst.  
Для гибкости и масштабируемости приложения использовал паттерны Стратегия и Репозиторий.
