using System;

/// <summary>
/// This class implements an array
/// </summary>
public class ArrayImplementation
{
    public int length;
    public object[] data;

    public ArrayImplementation()
    {
        this.length = 0;
        this.data = new object[1];
    }

    public object get(int item) { return this.data[item]; }

    public Object[] push(Object item)
    {
        if(this.data.Length == this.length)
        {
            //copy initial array to a temporary array of object
            Object[] temp = new Object[this.length];
            Array.Copy(this.data, temp, length);

            //Create a new array obejct with a bigger size to be able to add the new element later.
            this.data = new Object[length + 1];
            Array.Copy(temp, this.data, length);
        }
        this.data[this.length] = item;
        this.length++;
        return this.data;
    }

    private void shiftItems(int item)
    {
        for(int i = item; i < length - 1; i++)
        {
            this.data[i] = this.data[i + 1];
        }

        //now we need to remove that last item 
        this.data[length - 1] = null;

        this.length--;
    }

    public void delete(int item) { this.shiftItems(item); }

    public void pop()
    {
        this.data[this.length - 1] = null;
        this.length--;
    }
}

