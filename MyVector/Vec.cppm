module;
#include <iostream>

export module Vec;

export template <class T>
class vec
{
    T* ptr = nullptr;
    size_t lenght = 0;
    size_t capacity = 1;
    
 public:
    size_t len() const
    {
        return lenght;
    }
    size_t cap() const
    {
        return capacity;
    }

    vec()
    {
        ptr = new T[capacity];
    }

    void push(T item)
    {
        if (lenght < capacity) //just push back
        {
            ptr[lenght] = item;
            ++lenght;
        }
        else if (lenght == capacity) // reallocating vector
        {
            T* buffer = ptr;
            ptr = new T[capacity * 2];
    
            for (size_t i = 0; i < lenght; ++i)
            {
                ptr[i] = buffer[i];
            }
            delete[] buffer;

            ptr[lenght] = item;
            ++lenght;
            capacity *= 2;
        }
    }

    void concat(T* another)
    {
        throw std::exception("not implemented");
    }

    void display() //idk...
    {
        for (size_t i = 0; i < lenght; ++i)
        {
            std::cout << ptr[i] << ' ';
        }
        std::cout << '\n' << std::flush;
    }
};
