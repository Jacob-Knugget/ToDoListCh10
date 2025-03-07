﻿using ToDoList.Models;

public class ToDoViewModel
{
    public Filters Filters { get; set; } = new Filters("all-all-all");
    public List<Status> Statuses { get; set; } = new List<Status>();
    public List<Category> Categories { get; set; } = new List<Category>();
    public Dictionary<string, string> DueFilters { get; set; } = new Dictionary<string, string>();
    public List<ToDo> Tasks { get; set; } = new List<ToDo>();
    public ToDo CurrentTask { get; set; } = new ToDo(); // used for add
}