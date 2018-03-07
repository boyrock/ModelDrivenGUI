﻿using ModelDrivenGUISystem.Scope;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModelDrivenGUISystem.View {

    public class ClassView : BaseView {

        protected bool visible = true;

        public override void Draw() {
            using (new GUILayout.VerticalScope())
            using (new FoldoutScope(ref visible, Title)) {
                using (new IndentScope()) {
                    if (visible && Children != null)
                        foreach (var v in Children)
                            v.Draw();
                }
            }
        }
    }
}