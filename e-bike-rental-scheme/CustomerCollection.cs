using System;
namespace BikeManagement
{
	public class CustomerCollection : IBST
	{
		public class BTreeNode
		{
			private IComparable item; // Value
			private BTreeNode lchild; // Reference to its left child 
			private BTreeNode rchild; // Reference to its right child

			public BTreeNode(IComparable item)
			{
				this.item = item;
				lchild = null;
				rchild = null;
			}

			public IComparable Item
			{
				get { return item; }
				set { item = value; }
			}

			public BTreeNode LChild
			{
				get { return lchild; }
				set { lchild = value; }
			}

			public BTreeNode RChild
			{
				get { return rchild; }
				set { rchild = value; }
			}
		}

		public BTreeNode root;

		public CustomerCollection()
		{
			root = null;
		}

		public bool IsEmpty()
		{
			return root == null;
		}

		public Customer Search(IComparable item)
		{
			return Search(item, root);
		}

		private Customer Search(IComparable item, BTreeNode r)
		{
			if (r != null)
			{
				if (item.CompareTo(r.Item) == 0)
				{
					return (Customer)item;
				}
				else
					if (item.CompareTo(r.Item) < 0)
					return Search(item, r.LChild);
				else
					return Search(item, r.RChild);
			}
			else
				return null;
		}

		public void Insert(IComparable item)
		{
			if (root == null)
				root = new BTreeNode(item);
			else
				Insert(item, root);

		}


		private void Insert(IComparable item, BTreeNode ptr)
		{
			if (item.CompareTo(ptr.Item) < 0)
			{
				if (ptr.LChild == null)
					ptr.LChild = new BTreeNode(item);
				else
					Insert(item, ptr.LChild);
			}
			else
			{
				if (ptr.RChild == null)
					ptr.RChild = new BTreeNode(item);
				else
					Insert(item, ptr.RChild);
			}
		}


		public void Delete(IComparable item)
		{
			// Search for item and its parent
			BTreeNode ptr = root; // Search reference
			BTreeNode parent = null; // Parent of ptr
			while ((ptr != null) && (item.CompareTo(ptr.Item) != 0))
			{
				parent = ptr;
				// Move to the left child of ptr
				if (item.CompareTo(ptr.Item) < 0) 
					ptr = ptr.LChild;
				else
					ptr = ptr.RChild;
			}

			// If the search was successful
			if (ptr != null) 
			{
				// Case 3: item has two children
				if ((ptr.LChild != null) && (ptr.RChild != null))
				{
					// Find the right-most node in left subtree of ptr
					if (ptr.LChild.RChild == null) // Special case: the right subtree of ptr.LChild is empty
					{
						ptr.Item = ptr.LChild.Item;
						ptr.LChild = ptr.LChild.LChild;
					}
					else
					{
						BTreeNode p = ptr.LChild;
						BTreeNode pp = ptr; // Parent of p
						while (p.RChild != null)
						{
							pp = p;
							p = p.RChild;
						}
						// Copy the item at p to ptr
						ptr.Item = p.Item;
						pp.RChild = p.LChild;
					}
				}
				// Cases 1 & 2: item has no or only one child
				else
				{
					BTreeNode c;
					if (ptr.LChild != null)
						c = ptr.LChild;
					else
						c = ptr.RChild;

					// Remove node ptr
					if (ptr == root) // Need to change root
						root = c;
					else
					{
						if (ptr == parent.LChild)
							parent.LChild = c;
						else
							parent.RChild = c;
					}
				}

			}
		}

		public void InOrderTraverse()
		{
			InOrderTraverse(root);
			Console.WriteLine();
		}

		private void InOrderTraverse(BTreeNode root)
		{
			if (root != null)
			{
				InOrderTraverse(root.LChild);
				Console.Write(root.Item);
				InOrderTraverse(root.RChild);
			}
		}

		public void Clear()
		{
			root = null;
		}

	}

	}
