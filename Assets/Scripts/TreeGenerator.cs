using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject branchPrefab;
    public int maxDepth;
    public float angleBetweenBranches;

    private int currentDepth;
    private float branchLength;

    private void Start()
    {
        currentDepth = 0;
        branchLength = branchPrefab.GetComponent<Renderer>().bounds.size.y;
        GenerateBranches(transform);
    }

    private void GenerateBranches(Transform parent)
    {
        if (currentDepth >= maxDepth)
        {
            return;
        }

        currentDepth++;

        // Generate left branch
        GameObject leftBranch = Instantiate(branchPrefab, parent.position + parent.up * branchLength, Quaternion.identity, parent);
        leftBranch.transform.Rotate(Vector3.forward, angleBetweenBranches / 2);
        leftBranch.transform.position = parent.position + leftBranch.transform.up * branchLength;
        GenerateBranches(leftBranch.transform);

        // Generate right branch
        GameObject rightBranch = Instantiate(branchPrefab, parent.position + parent.up * branchLength, Quaternion.identity, parent);
        rightBranch.transform.Rotate(Vector3.forward, -angleBetweenBranches / 2);
        rightBranch.transform.position = parent.position + rightBranch.transform.up * branchLength;
        GenerateBranches(rightBranch.transform);

        currentDepth--;
    }
}
