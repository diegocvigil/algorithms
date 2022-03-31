class LinkedList:
    def __init__(self, value):
        self.value = value
        self.next = None

# O(n) time complexity | O(1) space complexity
def removeDuplicatesFromLinkedList(linkedList):
    currentItem = linkedList

    while currentItem is not None:
        nextItem = currentItem.next
        
        while nextItem is not None and nextItem.value == currentItem.value:
            nextItem = nextItem.next

        currentItem.next = nextItem
        currentItem = nextItem

    return linkedList