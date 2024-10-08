export module prototype;

export class smart_array  // NOLINT(cppcoreguidelines-special-member-functions)
{
    int* raw_data;
    size_t len;
    
public:
    smart_array()
    {
        raw_data = nullptr;
        len = 0;
    }

    smart_array(const int* arr, const size_t arr_len) : raw_data(nullptr), len(arr_len)
    {
        for (size_t i = 0; i < len; ++i)
        {
            raw_data[i] = arr[i];
        }
    }

    //copy constructor
    //explicit won't allow implicit conversion.
    //P.S. instances in copy constructor are passed by reference, and we don't allow it to *dereference it implicitly
    explicit smart_array(const smart_array* array)
    {
        raw_data = array->raw_data;
        len = array->len;
    }
    
    //move constructor (move semantics)
    //takes SmartArray rvalue reference as argument (usually used when data is going to be destroyed)
    smart_array(smart_array&& array) noexcept : raw_data(nullptr), len(0)
    {
        raw_data = array.raw_data;
        len = array.len;
        
        array.raw_data = nullptr;
        array.len = 0;
    }

    /// ------------- other-methods -------------
    /// display()
    /// getters()
    /// iterators()
};