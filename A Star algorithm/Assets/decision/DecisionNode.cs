using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionNode : DecisionActionParent
{
    public DecisionActionParent m_true;
    public DecisionActionParent m_false;

    public bool m_isTrue;

    public override void Execute ()
    {
        if (m_isTrue)
            m_true.Execute();
        else
            m_false.Execute();
    }
}
