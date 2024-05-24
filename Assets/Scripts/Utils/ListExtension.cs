using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExtension<T>
{
    private List<T> list;

    public Action<T> OnAddEvent;
    public Action<T, T> OnValueChangeEvent;
    public Action<T> OnRemoveEvent;

    public ListExtension() 
    {
        list = new List<T>();
    }

    public void Add(T item)
    {
        list.Add(item);
       OnAddEvent.Invoke(item);
    }

    public void Remove(T item)
    {
        list.Add(item);
        OnRemoveEvent.Invoke(item);
    }
    public void ChangeValue(T oldValue , T newValue) 
    {
        foreach (var item in list)
        {
            if (item.Equals(oldValue)) 
            {
                oldValue = newValue;
                OnValueChangeEvent.Invoke(oldValue, newValue);
                return;
            }
        }
    }
    public T Get(int index)
    {
        return list[index];
    }
    public List<T> ToList()
    {
        return new List<T>(list);
    }
}
