                ITreeChanges changes = repo.Diff.Compare(tree, tree);
                ITreeChanges changes = repo.Diff.Compare(tree, tree);
                ITreeChanges changes = repo.Diff.Compare(parentCommitTree, commitTree);
                ITreeChanges changes = repo.Diff.Compare(ancestor, tree, new[]{ "1", "2/" });
                ITreeChanges changes = repo.Diff.Compare(commitTreeWithDifferentAncestor, commitTree);
                ITreeChanges changes = repo.Diff.Compare(rootCommitTree, commitTreeWithRenamedFile);
                ITreeChanges changes = repo.Diff.Compare(rootCommitTree, commitTreeWithUpdatedFile);
                ITreeChanges changes = repo.Diff.Compare(rootCommitTree, mergedCommitTree);