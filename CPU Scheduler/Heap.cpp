
/**
 * Implementation for the Heap<E> class
 * @author Duncan
 * @since 99-99-9999
 * @see Heap.h
 */

#include "Heap.h"

using namespace std;

template <typename E>
Heap<E>::Heap()
{
    // compiler-generated code .. no need to implement this
}

template <typename E>
Heap<E>::~Heap()
{
    while (tree.size() > 0)
        tree.pop_back();
}

template <typename E>
bool Heap<E>::isEmpty() const
{
    if (tree.size() == 0)
        return true;
    else {
        HeapException("Tree Empty--isEmpty\n");
        return false;
    }
}

template<typename E>
void Heap<E>::insert(E item)
{
    std::vector<int>::iterator it = tree.end();
    tree.insert(it, item);
    
    //cout << "insert" << item << endl;
}

template<typename E>
E Heap<E>::remove() throw (HeapException)
{
    if (!isEmpty()) {
        tree.erase(tree.begin());
        if (!isEmpty()) {
            reheapify(0, tree.size());
            return tree.front();
        }
        return tree.front();
    }
    else {
        HeapException("Tree Empty--remove\n");
        return NULL;
    }
}

template<typename E>
const E& Heap<E>::peek() const throw (HeapException)
{
    if (!isEmpty())
        return tree.front();
        else{
        HeapException("Tree Empty--peek\n");
            return NULL;}
}

template<typename E>
int Heap<E>::size()const
{
    return tree.size();
}

template<typename E>
void Heap<E>::swap(int place, int parent)
{
    E temp = tree[parent];
    tree[parent] = tree[place];
    tree[place] = temp;
}

template<typename E>
void Heap<E>::reheapify(int root, int eSize)
{
    int Child = 2 * root + 1;
    int Parent = root;
    int count = 0;
    double layer = log2f(eSize + 1) - 1;
    (int)layer == layer ? (int)layer : (int)layer + 1;
    for (int i = 0; i < (int)layer; i++)
        count += (pow(2, i))*((int)layer - i);
    while (count >= 0 && Child < eSize && eSize > 1) {
        if ((Child + 1) < eSize && tree[Child + 1] < tree[Child])
            Child++;
        if (tree[Child] < tree[Parent])
            swap(Parent, Child);
        if (2 * Child + 1 >= eSize) {
            Child = (Child - 1) / 2 + 1;
            Parent = (Child - 2) / 2;
        }
        else {
            Parent = Child;
            Child = 2 * Child + 1;
        }
        count--;
    }
}


