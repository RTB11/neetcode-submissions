public class Node {
    public int val;
    public Node next;

    public Node(int val) {
        this.val = val;
        this.next = null;
    }
}

public class LinkedList {
    private Node head;

    public LinkedList() {
        head = null;
    }

    public int Get(int index) {
        Node current = head;
        int i = 0;

        while (current != null) {
            if (i == index)
                return current.val;

            current = current.next;
            i++;
        }

        return -1;
    }

    public void InsertHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
    }

    public void InsertTail(int val) {
        Node newNode = new Node(val);

        if (head == null) {
            head = newNode;
            return;
        }

        Node current = head;

        while (current.next != null) {
            current = current.next;
        }

        current.next = newNode;
    }

    public bool Remove(int index) {
        if (head == null)
            return false;

        // Xóa node đầu
        if (index == 0) {
            head = head.next;
            return true;
        }

        Node current = head;
        int i = 0;

        while (current != null && i < index - 1) {
            current = current.next;
            i++;
        }

        if (current == null || current.next == null)
            return false;

        current.next = current.next.next;
        return true;
    }

    public List<int> GetValues() {
        List<int> values = new List<int>();

        Node current = head;

        while (current != null) {
            values.Add(current.val);
            current = current.next;
        }

        return values;
    }
}