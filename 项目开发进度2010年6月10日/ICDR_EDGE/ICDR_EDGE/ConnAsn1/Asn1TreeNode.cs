using System;
using System.Windows.Forms;

namespace Asn1Processor
{
	/// <summary>
	/// Asn1TreeNode is derived from System.Windows.Forms.TreeNode.
	/// It includeds an Asn1Node member "asn1Node".
	/// </summary>
	public class Asn1TreeNode : TreeNode
	{
        private Asn1Node asn1Node = new Asn1Node();

        /// <summary>
        /// Get asn1Node member object.
        /// </summary>
        public Asn1Node ANode
        {
            get
            {
                return asn1Node;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        private Asn1TreeNode()
		{
		}

        /// <summary>
        /// Use an Asn1Node and display label mask to construct an Asn1TreeNode.
        /// Mask is defined in <see cref="Asn1Node.TagTextMask"/>.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="mask">mask <see cref="Asn1Node.TagTextMask"/>.</param>
        public Asn1TreeNode(Asn1Node node, uint mask)
        {
            asn1Node = node;
            this.Text = node.GetLabel(mask);
        }

		/// <summary>
		/// Following node.Adn1Node to add subnodes. It is special for paste a node tree.
		/// </summary>
		/// <param name="node">node.</param>
		/// <param name="mask">mask.</param>
		/// <param name="treeView">hosting TreeView control.</param>
		public static void AddSubNode(Asn1TreeNode node, uint mask, TreeView treeView)
		{
			for (int i=0; i<node.ANode.ChildNodeCount; i++)
			{
				Asn1TreeNode tNode = new Asn1TreeNode();
				tNode.asn1Node = node.ANode.GetChildNode(i);
				tNode.Text = tNode.ANode.GetLabel(mask);
				node.Nodes.Add(tNode);
				node.Expand();
				if (treeView != null)
					treeView.SelectedNode = node;
				AddSubNode(tNode, mask, treeView);
			}
		}

        /// <summary>
        /// Search a Asn1Node in the sub tree of treeNode.
        /// </summary>
        /// <param name="treeNode">The sub tree node.</param>
        /// <param name="node">The Asn1Node node.</param>
        /// <returns></returns>
        public static TreeNode SearchTreeNode(TreeNode treeNode, Asn1Node node)
        {
            TreeNode retval = null;
            if (node == null) return retval;
            if (((Asn1TreeNode)treeNode).ANode == node) return treeNode;
            Asn1Node tmpTreeNode;
            for (int i =0; i<treeNode.Nodes.Count; i++)
            {
                tmpTreeNode = ((Asn1TreeNode) treeNode.Nodes[i]).ANode;
                if (tmpTreeNode == node)
                {
                    retval = treeNode.Nodes[i];
                    break;
                }
                retval = SearchTreeNode(treeNode.Nodes[i], node);
                if (retval != null)
                    break;
            }
            return retval;
        }

	}
}
